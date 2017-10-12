using System;
using System.Collections;

namespace AED
{

    #region Classe CCelula - representa a célula utilizada pelas classes CLista, CFila e CPilha
    /// <summary>
    /// Classe utilizada pelas classes CLista, CFila e CPilha
    /// </summary>
    class CCelula
    {
        public Object Item; // O Item armazendo pela célula
        public CCelula Prox; // Referencia a próxima célula

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo null aos atributos Item e Prox.
        /// </summary>
        public CCelula()
        {
            Item = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo o valor passado por parâmetro ao atributo Item e null ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        public CCelula(object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo ValorItem ao atributo Item e ProxCelula ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula</param>
        /// <param name="ProxCelula">Referência para a próxima célula.</param>
        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
    #endregion

    #region Classe CCelulaDup - representa a célula utilizada pela classe CListaDup
    /// <summary>
    /// Classe utilizada pela classe CListaDup
    /// </summary>
    class CCelulaDup
    {

        public Object Item; // O Item armazendo pela célula
        public CCelulaDup Ant; // Referencia a célula anterior
        public CCelulaDup Prox; // Referencia a próxima célula

        /// <summary>
        /// Inicializa uma nova instância da classe CCelulaDup atribuindo null aos atributos Item, Ant e Prox.
        /// </summary>
        public CCelulaDup()
        {
            Item = null;
            Ant = null;
            Prox = null;
        }



        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo o valor passado por parâmetro ao atributo Item e null aos atributos Ant e Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        public CCelulaDup(object ValorItem)
        {
            Item = ValorItem;
            Ant = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo ValorItem ao atributo Item e ProxCelular ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        /// <param name="celulaAnt">Referência para a célula anterior.</param>
        /// <param name="ProxCelula">Referência para a próxima célula.</param>
        public CCelulaDup(object ValorItem,
                          CCelulaDup celulaAnt,
                          CCelulaDup proxCelula)
        {
            Item = ValorItem;
            Ant = celulaAnt;
            Prox = proxCelula;
        }
    }
    #endregion

    #region Classe CLista - Lista encadeada (simples) com célula cabeça
    /// <summary>
    /// Implementa uma lista encadeada com célula cabeça.
    /// </summary>
    class CLista
    {
        private CCelula Primeira; // Referencia a célula cabeça 
        private CCelula Ultima; // Referencia a última célula da lista
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Aloca a célula cabeça e faz todas as referências apontarem para ela.
        /// </summary>
        public CLista()
        {
            Primeira = new CCelula();
            Ultima = Primeira;
        }

        /// <summary>
        /// Verifica se a lista está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a lista estiver vazia e FALSE se ela tiver elementos.</returns>
        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        /// <summary>
        /// Insere um novo Item no fim da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void InsereFim(Object ValorItem)
        {
            Ultima.Prox = new CCelula(ValorItem);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        /// <summary>
        /// Insere um novo Item no começo da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void InsereComeco(Object ValorItem)
        {
            Primeira.Prox = new CCelula(ValorItem, Primeira.Prox);
            if (Primeira.Prox.Prox == null)
                Ultima = Primeira.Prox;
            Qtde++;
        }

        /// <summary>
        /// Imprime todos os elementos da lista usando o comando while
        /// </summary>
        public void Imprime()
        {
            CCelula aux = Primeira.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Prox;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista usando o comando for
        /// </summary>
        public void ImprimeFor()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write(aux.Item);
        }

        /// <summary>
        /// Imprime todos os elementos simulando formato de lista: [/]->[7]->[21]->[13]->null
        /// </summary>
        public void ImprimeFormatoLista()
        {
            Console.Write("[/]->");
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write("[" + aux.Item.ToString() + "]->");
            Console.WriteLine("null");
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">O Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Primeira.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">O Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Primeira.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Remove e retorna o primeiro Item da lista (remoção física, ou seja, elimina a célula que contém o elemento).
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaComeco()
        {
            // Verifica se há elementos na lista
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira.Prox;
                Primeira.Prox = aux.Prox;
                if (Primeira.Prox == null) // Se a célula cabeça está apontando para null, significa que o único elemento da lista foi removido
                    Ultima = Primeira;
                Qtde--;
                return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove e retorna o primeiro Item da lista (remoção lógica, ou seja, remove a célula cabeça fazendo com que a célula seguinte ela se torne a nova célula cabeça).
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaComecoSimples()
        {
            // Verifica se há elementos na lista
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
                return Primeira.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove o primeiro Item da lista fazendo com que a célula seguinte à célula cabeça se torne a nova célula cabeça. Não retorna o Item removido.
        /// </summary>
        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
            }
        }

        /// <summary>
        /// Remove o último Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                CCelula aux2 = aux.Prox;
                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
                return aux2.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove o último Item da lista sem retorná-lo.
        /// </summary>
        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Localiza o Item passado por parâmetro e o remove da Lista
        /// </summary>
        /// <param name="ValorItem">Item a ser removido da lista.</param>
        public void Remove(Object ValorItem)
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                bool achou = false;
                while (aux.Prox != null && !achou)
                {
                    achou = aux.Prox.Item.Equals(ValorItem);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    aux.Prox = aux.Prox.Prox;
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
        }

        /// <summary>
        /// Retorna o primeiro Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o primeiro Item da lista. Se a lista estiver vazia ou pos estiver posicionado em uma posição inválida a função retorna null.</returns>
        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.Prox.Item;
            else
                return null;
        }

        /// <summary>
        /// Retorna o último Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o último Item da lista. Se a lista estiver vazia ou pos estiver posicionado em uma posição inválida a função retorna null.</returns>
        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.Item;
            else
                return null;
        }

        /// <summary>
        /// Retorna o Item contido na posição p da lista.
        /// </summary>
        /// <param name="p">A posição desejada. A primeira posição da lista é a posição 1.</param>
        /// <returns>Um Object contendo o Item da posição p da lista.</returns>
        public Object RetornaIndice(int Posicao)
        {
            // EXERCÍCIO : deve retornar o elemento da posição p passada por parâmetro
            // [cabeça]->[7]->[21]->[13]->null
            // retornaIndice(2) deve retornar o elemento 21. retornaIndice de uma posiçao inexistente deve retornar null.
            // Se é uma posição válida e a lista possui elementos
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                int i = 1;
                CCelula aux = Primeira.Prox;
                // Procura a posição a ser inserido
                while (i < Posicao)
                {
                    aux = aux.Prox;
                    i++;
                }
                return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da lista.
        /// </summary>
        /// <returns>Quantidade de itens da lista.</returns>
        public int Quantidade()
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CLista usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }
    }
    #endregion

    #region Classe CFila - Fila (ou lista FIFO: first-in first-out)
    /// <summary>
    /// Classe que representa uma Fila (ou lista FIFO: first-in first-out)
    /// </summary>
    class CFila
    {
        private CCelula Frente; // Referencia a primeira célula da CFila (Célula cabeça)
        private CCelula Tras; // Referencia a última célula da CFila
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Cria a célula cabeça e faz as referências Frente e Tras apontarem para ela.
        /// </summary>
        public CFila()
        {
            Frente = new CCelula();
            Tras = Frente;
        }

        public void ImprimeFor()
        {
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                Console.Write("\n" + aux.Item);
        }

        public void Limpa()
        {
            CCelula aux = Frente;
            while (Qtde != 0)
            {
                aux.Prox = null;
                Qtde--;
            }
            Tras = Frente;
        }

        public void FuraFila(CFila Origem, object Elemento)
        {
            Queue aux = new Queue();
            foreach (object op in Origem)
                aux.Enqueue(op);

            Origem.Limpa();
            Origem.Enfileira(Elemento);

            foreach (object op1 in aux)
                Origem.Enfileira(op1);
        }

        /// <summary>
        /// Verifica se a fila está vazia
        /// </summary>
        /// <returns>Retorna TRUE se a lista estiver vazia e FALSE caso contrário.</returns>
        public bool Vazia()
        {
            return Frente == Tras;
        }

        /// <summary>
        /// Insere um novo Item no fim da fila.
        /// </summary>
        /// <param name="ValorItem">Um Object contendo o elemento a ser inserido no final da fila.</param>
        public void Enfileira(Object ValorItem)
        {
            Tras.Prox = new CCelula(ValorItem);
            Tras = Tras.Prox;
            Qtde++;
        }

        /// <summary>
        /// Retira e retorna o primeiro elemento da fila.
        /// </summary>
        /// <returns>Um Object contendo o primeiro elemento da fila. Caso a fila esteja vazia retorna null.</returns>
        public Object Desenfileira()
        {
            Object Item = null;
            if (Frente != Tras)
            {
                Frente = Frente.Prox;
                Item = Frente.Item;
                Qtde--;
            }
            return Item;
        }

        /// <summary>
        /// Retorna o primeiro Item da fila sem removê-lo.
        /// </summary>
        /// <returns>Um Object contendo o primeiro Item da fila.</returns>
        public Object Peek()
        {
            if (Frente != Tras)
                return Frente.Prox.Item;
            else
                return null;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Frente.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Frente.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da fila.
        /// </summary>
        /// <returns>Quantidade de itens da fila.</returns>
        public int Quantidade() //Função
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CFila usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }
    }
    #endregion

    #region Classe CPilha - CPilha (ou lista LIFO: last-in first-out)
    /// <summary>
    /// Classe que representa uma Pilha (ou lista LIFO: last-in first-out)
    /// </summary>
    class CPilha
    {
        private CCelula Topo = null;
        private int Qtde = 0;

        /// <summary>
        /// Função construtora.
        /// </summary>
        public CPilha()
        {
            // nenhum código
        }
        public void ImprimeFor()
        {
            for (CCelula aux = Topo; aux != null; aux = aux.Prox)
                Console.Write("\n" + aux.Item);
        }

        /// <summary>
        /// Verifica se a Pilha está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a PILHA estiver vazia e FALSE caso contrário.</returns>
        public bool Vazia()
        {
            return Topo == null;
        }

        /// <summary>
        /// Insere o novo Item no Topo da Pilha
        /// </summary>
        /// <param name="ValorItem">Um Object contendo o Item a ser inserido no Topo da Pilha.</param>
        public void Empilha(Object ValorItem)
        {
            Topo = new CCelula(ValorItem, Topo);
            Qtde++;
        }

        /// <summary>
        /// Retira e retorna o Item do Topo da Pilha.
        /// </summary>
        /// <returns>Um Object contendo o Item retirado do Topo da Pilha. Caso a Pilha esteja vazia retorna null.</returns>
        public Object Desempilha()
        {
            Object Item = null;
            if (Topo != null)
            {
                Item = Topo.Item;
                Topo = Topo.Prox;
                Qtde--;
            }
            return Item;
        }
        ///<summary>
        ///Colocam todas as celulas para apontarem para null assim deixam de existir.
        /// </summary>
        public void Limpa()
        {
            CCelula aux = Topo;
            while (Qtde != 0)
            {
                aux.Prox = null;
                Qtde--;
            }
            Topo = null;
        }
        
        ///<summary>
        ///Recebe um elemento como parametro e o coloca no fundo da pilha que tambem foi recebida como parametro
        /// </summary>

        public void VaiParaOFundoPilha(CPilha Origem, object Elemento)
        {
            Stack aux = new Stack();
            foreach (object op in Origem)
                aux.Push(op);
            
            Origem.Limpa();
            Origem.Empilha(Elemento);
            
            foreach (object op1 in aux)
                Origem.Empilha(op1);
        }
        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Topo;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Topo; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Retorna o Item do Topo da Pilha sem removê-lo.
        /// </summary>
        /// <returns>Um Object contendo o Item do Topo da Pilha. Caso a Pilha esteja vazia retorna null.</returns>
        public Object Peek()
        {
            if (Topo != null)
                return Topo.Item;
            else
                return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da Pilha.
        /// </summary>
        /// <returns>Quantidade de itens da Pilha.</returns>
        public int Quantidade() //Função
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CPilha usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Topo; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

    }
    #endregion

    #region Classe CListaDup - Lista duplamente encadeada com célula cabeça
    /// <summary>
    /// Implementa uma lista duplamente encadeada.
    /// </summary>
    class CListaDup
    {
        private CCelulaDup Primeira; // Referencia a primeira célula da lista (célula cabeça)
        private CCelulaDup Ultima; // Referencia a última célula da lista 
        private int Qtde = 0;

        /// <summary>
        /// Aloca a célula cabeça e faz todas as referências
        /// apontarem para ela.
        /// </summary>
        public CListaDup()
        {
            Primeira = new CCelulaDup();
            Ultima = Primeira;
        }

        public void Limpa()
        {
            CCelulaDup aux = Primeira;
            while (Qtde != 0)
            {
                aux.Prox = null;
                Qtde--;
            }
            Ultima = Primeira;
        }
        /// <summary>
        /// Verifica se a lista está vazia.
        /// </summary>
        /// <returns>Retorna true se a lista estiver vazia.</returns>
        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        /// <summary>
        /// Insere um novo elemento no fim da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido no final da lista.</param>
        public void InsereFim(Object ValorItem)
        {
            Ultima.Prox = new CCelulaDup(ValorItem, Ultima, null);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        /// <summary>
        /// Insere um novo elemento no começo da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido no começo da lista.</param>
        public void InsereComeco(Object ValorItem)
        {
            if (Primeira == Ultima) // Se a lista estiver vazia insere no fim
            {
                Ultima.Prox = new CCelulaDup(ValorItem, Ultima, null);
                Ultima = Ultima.Prox;
            }
            else // senão insere no começo
            {
                Primeira.Prox = new CCelulaDup(ValorItem, Primeira, Primeira.Prox);
                Primeira.Prox.Prox.Ant = Primeira.Prox;
            }
            Qtde++;
        }

        /// <summary>
        /// Insere o Item passado por parâmetro na posição determinada.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido na lista.</param>
        /// <param name="Posicao">Posição na qual o elemento será inserido. O primeiro elemento está na posição 1, e assim por diante.</param>
        /// <returns>Se a posição existir, retorna TRUE. Caso a posição não exista, retorna FALSE</returns>
        public bool InsereIndice(Object ValorItem, int Posicao)
        {
            // Verifica se a posição passada por parâmetro é uma posição válida, ou seja, no intervalo entre 1 e Qtde+1
            if (Posicao >= 1 && Posicao <= Qtde + 1)
            {
                CCelulaDup aux = Primeira;
                // Procura a posição a ser inserido
                for (int i = 0; i < Posicao - 1; aux = aux.Prox, i++) ;
                aux.Prox = new CCelulaDup(ValorItem, aux, aux.Prox);
                if (aux.Prox.Prox != null) // se a célula inserida não é a última
                    aux.Prox.Prox.Ant = aux.Prox;
                else // se a célula é a última
                    Ultima = aux.Prox;
                Qtde++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove o primeiro elemento da lista. Na verdade, remove a referência para a célula cabeça, e torna a primeira célula na nova célula cabeça
        /// </summary>
        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Primeira.Ant = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Remove o último elemento da lista. Na verdade, remove as referências para a última célula, forçando que o Garbage Collector desaloque a última célula
        /// </summary>
        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Ultima = Ultima.Ant;
                Ultima.Prox = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Localiza o Item passado por parâmetro e o remove da Lista
        /// </summary>
        /// <param name="ValorItem">Item a ser removido da lista.</param>
        public void Remove(Object ValorItem)
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Primeira.Prox;
                bool achou = false;
                while (aux != null && !achou)
                {
                    achou = aux.Item.Equals(ValorItem);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    CCelulaDup anterior = aux.Ant;
                    CCelulaDup proximo = aux.Prox;
                    anterior.Prox = proximo;
                    if (proximo != null)
                        proximo.Ant = anterior;
                    else
                        Ultima = anterior;
                    Qtde--;
                }
            }
        }

        /// <summary>
        /// Remove e retorna o primeiro elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o primeiro elemento da lista.</returns>
        public Object RemoveRetornaComeco()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Primeira.Prox;
                Primeira = Primeira.Prox;
                Primeira.Ant = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }

        /// <summary>
        /// Remove e retorna o último elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o último elemento da lista.</returns>
        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Ultima;
                Ultima = Ultima.Ant;
                Ultima.Prox = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada usando o comando while.
        /// </summary>
        public void Imprime()
        {
            CCelulaDup aux = Primeira.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Prox;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada usando o comando for.
        /// </summary>
        public void ImprimeFor()
        {
            for (CCelulaDup aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.WriteLine(aux.Item);
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada em sentido inverso usando o comando while.
        /// </summary>
        public void ImprimeInv()
        {
            CCelulaDup aux = Ultima;
            while (aux.Ant != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Ant;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada em sentido inverso usando o comando for.
        /// </summary>
        public void ImprimeInvFor()
        {
            for (CCelulaDup aux = Ultima; aux.Ant != null; aux = aux.Ant)
                Console.WriteLine(aux.Item);
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelulaDup aux = Primeira.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelulaDup aux = Primeira.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public void RemovePos(int n)
        {
            CCelulaDup aux = Primeira.Prox;
            if (Primeira != Ultima)
            {
                if ((n >= 1) && (n <= Qtde))
                {
                    int cont = 1;
                    while (cont < n)
                    {
                        aux = aux.Prox;
                        cont++;
                    }

                    aux.Prox = aux.Prox.Prox;
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
        }

        /// <summary>
        /// Retorna o primeiro elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o primeiro elemento da lista ou null caso a lista esteja vazia.</returns>
        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.Prox.Item;
            return null;
        }

        /// <summary>
        /// Retorna o Item contido na posição p da lista.
        /// </summary>
        /// <param name="p">A posição desejada. A Primeira posição da lista é a posição 1.</param>
        /// <returns>Um Object contendo o Item da posição p da lista.</returns>
        public Object RetornaIndice(int Posicao)
        {
            // EXERCÍCIO : deve retornar o elemento da posição p passada por parâmetro
            // [cabeça]->[7]->[21]->[13]->null
            // retornaIndice(2) deve retornar o elemento 21. retornaIndice de uma posiçao inexistente deve retornar null.
            // Se é uma posição válida e a lista possui elementos
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                CCelulaDup aux = Primeira.Prox;
                // Procura a posição a ser inserido
                for (int i = 1; i < Posicao; i++, aux = aux.Prox) ;
                if (aux != null)
                    return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Retorna o elemento da última posição.
        /// </summary>
        /// <returns>Um object contendo o último elemento da lista ou null caso a lista esteja vazia.</returns>
        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.Item;
            return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de elementos da lista.
        /// </summary>
        /// <returns>Quantidade de elementos da lista.</returns>
        public int Quantidade()
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CListaDup usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelulaDup aux = Primeira.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        /// <summary>
        /// Permite iterar sobre uma CListaDup de forma invertida usando o comando foreach
        /// </summary>
        /// Exemplo de uso: foreach(Object x in LD.Reverse)
        public IEnumerable Reverse
        {
            get
            {
                for (CCelulaDup aux = Ultima; aux != Primeira; aux = aux.Ant)
                    yield return aux.Item;
            }
        }

    }
    #endregion

    #region Classe CDicionario
    class CDicionario
    {
        class CCelulaDicionario
        {
            // Atributos
            public Object key, value;
            public CCelulaDicionario prox;
            // Construtora que anula os três atributos da célula
            public CCelulaDicionario()
            {
                key = null;
                value = null;
                prox = null;
            }
            // Construtora que inicializa key e value com os argumentos passados
            // por parâmetro e anula a referência à próxima célula
            public CCelulaDicionario(Object chave, Object valor)
            {
                key = chave;
                value = valor;
            }
            // Construtora que inicializa todos os atribulos da célula com os argumentos
            // passados por parâmetro
            public CCelulaDicionario(Object chave, Object valor, CCelulaDicionario proxima)
            {
                key = chave;
                value = valor;
                prox = proxima;
            }
        }

        private CCelulaDicionario primeira, ultima;
        
        public CDicionario()
        {
            primeira = new CCelulaDicionario();
            ultima = primeira;
        }
        public bool Vazio()
        {
            return primeira == ultima;
        }
        public void Adiciona(Object chave, Object valor)
        {
            ultima.prox = new CCelulaDicionario(chave,valor,primeira.prox);
            ultima = ultima.prox;
        }

        public Object RecebeValor(Object chave)
        {
            if (primeira != ultima)
            {
                for (CCelulaDicionario i = primeira.prox; i != null; i=i.prox)
                {
                    if(i.key.Equals(chave))
                        return i.value;
                }

            }
            return null;
       }

        public void Imprime() 
        {
            for (CCelulaDicionario aux = primeira; aux != null; aux = aux.prox)
                Console.Write("\n" + aux.key + "|" + aux.value);
        }
    }

    class HashtableDicionario
    {
        public void criacaoHash(string url)
        {
            CDicionario CD = new CDicionario();
             Hashtable URL = new Hashtable()
             {
                 {"www.google.com", "173.194.119.20" } ,{"www.amazon.com", "176.32.103.205" } ,
                 {"www.pucminas.br", "200.229.43.1" } , {"research.microsoft.com", "131.107.65.14" } ,
                 {"www.gmail.com", "216.58.222.5" } , {"www.facebook.com", "67.171.230.5" } ,
                 {"www.youtube.com", "173.194.118.85" } , {"www.whitehouse.gov", "23.77.40.38" } ,
                 {"www.capes.gov.br", "200.130.18.222" } , {"www.answers.com", "67.196.156.65" } ,
                 {"www.yahoo.com", "200.152.175.146" } , {"www.uol.com.br", "200.221.2.45" } ,
                 {"www.microsoft.com", "23.76.203.113" } , {"www.hotmail.com", "65.65.65.188" },
                 {"www.twitter.com", "199.16.158.104" } , {"www.cplusplus.com", "167.114.170.15" } ,
                 {"www.brasil.gov.br", "161.148.175.40" } , {"www.nyt.com", "170.149.159.130" } ,
                 {"www.wikipedia.com", "208.80.154.224" } , {"www.apple.com", "104.88.124.67" },
                 {"www.algartech.com.br", "191.96.5.63" }, {"www.sotreq.com.br", "174.132.119.180" },
                 {"www.globo.com", "186.192.82.163" }, {"www.santander.com.br", "23.76.245.229" },
                 {"www.linx.com.br", "186.202.179.135" }
             };

            foreach (DictionaryEntry DE in URL)
                CD.Adiciona(DE.Key, DE.Value);

           
            if (URL.ContainsKey(url))
               Console.WriteLine(" URL: " + url + "\t IP: " + CD.RecebeValor(url));
            else
              Console.Write(" \n ERRO! URL não cadastrada");
            Console.ReadKey();
                
        }
    }
    
    #endregion

#region CListaSimples
    class CListaSimples
    {
        class CCelula
        {
            public int item;
            public CCelula prox;
        }

        private CCelula primeira, ultima;

        public CListaSimples()// Código da função construtora
        {
            primeira = null;
            ultima = null; 
        }

        public bool Vazia()// Código para verificar se a Lista está vazia
        {
            return primeira == ultima; 
        }

        public void InsereComeco(Object valorItem)// Código para inserir valorItem no início da Lista
        {
            CCelula aux = new CCelula();
      
            aux.item = (int)valorItem;
            if (primeira == null)
            {
                primeira = aux;
                ultima = primeira;
            }
            else 
            {
                aux.prox = primeira;
                primeira = aux;
                ultima = primeira;
            }
            
        }

        public Object RemoveComeco()// Código para remover e retornar o elemento do início da Lista
        {
            if (primeira != ultima)
            {
                primeira = primeira.prox;

                return primeira.item;
            }
            return null;
        }

        public void InsereFim(Object valorItem)// Código para inserir valorItem no fim da Lista
        {
            ultima.prox = new CCelula();
            ultima.prox.item = (int)valorItem;
            ultima = ultima.prox; 
        }

        public Object RemoveFim()// Código para remover e retornar o elemento do fim da Lista
        {
            if (primeira != ultima)
            {
                CCelula aux = primeira;
                while (aux.prox != ultima)
                    aux = aux.prox;

                CCelula aux2 = aux.prox;
                ultima = aux;
                ultima.prox = null;
                return aux2.item;
            }
            return null; 
        }

        public void Imprime() // Código para imprimir todos os elementos da Lista
        {
            for (CCelula aux = primeira; aux != null; aux = aux.prox)
                Console.Write("[" + aux.item.ToString() + "]->");
            Console.WriteLine("null");
        }

        public bool Contem(Object elemento)// Código para verifica se a Lista contem o elemento passado como parâmetro
        {
            bool achou = false;
            CCelula aux = new CCelula();

            for ( aux = primeira.prox; aux != null && !achou; aux = aux.prox)
                achou = aux.item.Equals(elemento);
            return achou;
        }
    }
#endregion
    class Program
    {
        static void Main(string[] args)
        {
             string url;
             CDicionario CD = new CDicionario();
             HashtableDicionario HS = new HashtableDicionario();
             Console.Write("\n Informe a URL do site que deseja saber o IP: ");
             url =  Console.ReadLine();
             HS.criacaoHash(url);
             
             Console.Title = "URLs / IPs";
             Console.Clear();
             Console.WriteLine("Obrigada por utilizar nosso programa!");
            
            Console.ReadKey();
        }
    }
}