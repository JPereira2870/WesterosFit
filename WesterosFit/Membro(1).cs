using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Membro
    {
        public string m_nome;
        public int m_idade;
        public int m_nivel;
        public int m_experiencia;
        public int m_presencas;
        public int m_nDiasUltimaPresenca;
        public int m_desconto;
        public bool m_SPA;
        public bool m_ativo;
        public int m_infracoes;

        public string Nome
        {
            get { return m_nome; }

            set
            {
                if (value == "")
                    m_nome = value;
            }
        }

        public int Idade
        {
            get { return m_idade; }

            set { m_idade = value; }
        }

        public int Nivel
        {
            get { return m_nivel; }            
        }

        public int Experiencia
        {
            get { return m_experiencia; }
        }

        public int Presencas
        {
            get { return m_presencas; }
            set
            {
                if (value > 0)
                    m_presencas = value;
            }
        }

        public int NumeroDiasUltimaPresenca
        {
            get { return m_nDiasUltimaPresenca; }
            set
            {
                if (value > 0)
                    m_nDiasUltimaPresenca = value;
            }
        }

        public int Desconto
        {
            get { return m_desconto; }
            set
            {
                if (value > 0)
                    m_desconto = value;
            }
        }

        public bool SPA
        {
            get { return m_SPA; }
            set { m_SPA = value; }
        }

        public bool Ativo
        {
            get { return m_ativo; }
            set { m_ativo = value; }
        }

        public int Infracoes
        {
            get { return m_infracoes; }
            set
            {
                if (value > 0)
                    m_infracoes = value;
            }
        }

        public double MensalidadeBase()
        {
            double mensalidadeBase;

            mensalidadeBase = 39.90 - m_desconto;

            return mensalidadeBase;
        }

        public virtual bool VerificarDedicacao()
        {
            if (m_presencas >= 10)
                return true;
            
            else
            {
                m_infracoes++;
                if (m_infracoes >= 3)
                {
                    m_ativo = false;
                }
                return false;                
            }       
                                              
        }

        public double Mensalidade()
        {
            double mensalidade;

            mensalidade = MensalidadeBase() + 2;

            if (SPA)
                mensalidade = mensalidade + 10;

            if (VerificarDedicacao())
                mensalidade = mensalidade + 25;

            return mensalidade;
        }

        public void MarcarPresencas()
        {
            if (m_ativo)
            {
                m_presencas++;
                m_experiencia++;
                AtualizarNivel();
            }                
        }

        public void MarcarPresencas(int presencas)
        {
            if (m_ativo)
            {
                m_presencas = m_presencas + presencas;
                m_experiencia = m_experiencia + presencas;
                AtualizarNivel();
            }
                
        }

        public void AtualizarNivel()
        {
            if((m_nivel*2+10) <= m_experiencia)
            {
                m_experiencia = m_experiencia - (m_nivel * 2 + 10);
                m_nivel++;                
            }

        }

        

       
        public Membro (string nome, int idade)
        {
            m_nome = nome;
            m_idade = idade;
            m_nivel = 0;
            m_presencas = 0;
            m_ativo = true;
            m_SPA = false;
            m_nDiasUltimaPresenca = 0;
            m_desconto = 0;
        }

    }
}
