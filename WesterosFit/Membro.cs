using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesterosFit
{
    public abstract class Membro
    {
        #region  Campos
        private string m_nome;
        private int m_idade;
        private int m_nivel;
        private int m_experiencia;
        private int m_presencas;
        private int m_numeroDiasUltimaPresenca;
        private double m_desconto;
        private bool m_spa;
        private bool m_ativo;
        private int m_infracoes;
        private string m_classe; // Permite identificar o tipo de membro na tabela       
        private int m_id;
        private int m_pontosPorPresenca;
        private static int m_numeroMembros; // static faz com que a variavel não seja reinicializada sempre que é criado um novo membro. É estatica durante todo o funcionamento do programa
        #endregion

        #region Propriedades
        public string Classe
        {
            get { return m_classe; }
            set { m_classe = value; } // Para atribuir valores diferentes a cada subclasse
        }

        public string Nome
        {
            get { return m_nome; }            
        }

        public int Idade
        {
            get { return m_idade; }
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
        }

        public int PontosPorPresenca
        {
            get { return m_pontosPorPresenca; }
            set { m_pontosPorPresenca = value; } //Pontos difernetes para cada subclasse
        }

        public int NumeroDiasUltimaPresenca
        {
            get { return m_numeroDiasUltimaPresenca; }
        }

        public double Desconto
        {
            get { return m_desconto; }
            set { m_desconto = value; } // Para que possa ser atribuido um desconto pelo código cliente
        }

        public bool SPA
        {
            get { return m_spa; }
        }

        public bool Ativo
        {
            get { return m_ativo; }
        }

        public int Infracoes
        {
            get { return m_infracoes; }
            set { m_infracoes = value; } // Para que possa atribuir infrações em cada método VerificarDedicacao()
        }

        public int ID
        {
            get { return m_id; }
        }
        #endregion

        #region Métodos

        public void AtivarDesativarMembro() // permite ao utilizador desativar um membro que queira desistir ou reativar outro que pretenda voltar
        {
            if (m_ativo)
                m_ativo = false;
            else
                m_ativo = true;
        }
        
        public double MensalidadeBase()
        {
            double mensalidadeBase;

            mensalidadeBase = 39.90 - m_desconto;

            return mensalidadeBase;
        }

        public virtual double MensalidadeEfetiva()
        {
            double mensalidade;

            mensalidade = MensalidadeBase() + 2;

            if (SPA)
                mensalidade = mensalidade + 10;

            if (!VerificarDedicacao())
            {
                mensalidade = mensalidade + 25;
                m_infracoes--; 
            }
            
            if (mensalidade < 0 || m_ativo == false )// No caso do Ned ter mais de 100 anos o ginásio não ter de lhe pagar ou o Menbro não estar ativo
                mensalidade = 0; 


            return mensalidade;
        }

        public virtual bool VerificarDedicacao()
        {
            if (m_presencas >= 10)
            {
                return true;
            }                    
            else
            {
                m_infracoes++;
                AtualizarEstado();
                return false;                
            }                                              
        }
        public void AtualizarEstado()
        {
            if (m_infracoes >= 3)
            {
                m_ativo = false;
            }
        }

        public void AtualizarNivel()
        {
            while ((m_nivel * 2 + 10) <= m_experiencia)
            {
                m_experiencia = m_experiencia - (m_nivel * 2 + 10);
                m_nivel++;
            }
        }

        public void MarcarPresencas()
        {
            if (m_ativo)
            {
                m_presencas++;
                m_experiencia = m_experiencia + m_pontosPorPresenca ;
                m_numeroDiasUltimaPresenca = 0;
                AtualizarNivel();
            }                
        }

        public void MarcarPresencas(int presencas)
        {            
            if (m_ativo)
            {
                m_presencas = m_presencas + presencas;
                m_experiencia = m_experiencia + presencas * m_pontosPorPresenca;
                m_numeroDiasUltimaPresenca = 0;
                AtualizarNivel();
            }               
        }

        public void MarcarDiasQueNaoFoiAoGinasio(int numeroDeDiasDesdeUltimaPresenca)
        {
            if (m_ativo)
            {
                m_numeroDiasUltimaPresenca = m_numeroDiasUltimaPresenca + numeroDeDiasDesdeUltimaPresenca;
            }
        }
              
        public bool ReativarMembro() // bool para saber se o membro foi reativado ou se não pode ainda
        {
            if (!m_ativo && m_numeroDiasUltimaPresenca >= 100)
            {
                m_ativo = true;

                if (m_nivel < 10)
                    m_nivel = 0;
                else
                    m_nivel = m_nivel - 10;

                m_infracoes = 0;
                m_experiencia = 0;
                return true;
            }
            else
                return false;
        }

        public void AtivarDesativarSPA()
        {
            if (m_spa)
                m_spa = false;
            else
                m_spa = true;
        }

        public abstract bool GuardioesDaNoite(); // cada subclasse fornece o seu código (obrigatório)

        #endregion

        public Membro (string nome, int idade)
        {
            m_nome = nome;
            m_idade = idade;
            m_nivel = 0;
            m_presencas = 0;
            m_experiencia = 0; 
            m_ativo = true;
            m_spa = false;
            m_numeroDiasUltimaPresenca = 0;
            m_desconto = 0;
            m_id = m_numeroMembros;
            m_numeroMembros++;
        }
    }
}
