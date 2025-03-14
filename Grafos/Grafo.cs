using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Grafo<T>
    {
        private Dictionary<T, List<T>> _grafo;

        public Grafo()
        {
           _grafo = new Dictionary<T, List<T>>();
        }

        void CriarVertice(T vertice)
        {
            if (_grafo.ContainsKey(vertice))
            {
                throw new InvalidOperationException($"Elemento {vertice} repetido.");
            }

            _grafo.Add(vertice, new List<T>());
        }

        void CriarVertice(T vertice, List<T> vizinhos)
        {
            if (_grafo.ContainsKey(vertice))
            {
                throw new InvalidOperationException($"Elemento {vertice} repetido.");
            }
            
            _grafo.Add(vertice, vizinhos);
            foreach (T v in vizinhos)
            {
                if(!_grafo.ContainsKey(v)) CriarVertice(v);
            }
        }

        //criar conexão entre dois vertices
        void CriarAresta(T origem, T destino)
        {
            if (!_grafo.ContainsKey(origem)) CriarVertice(origem);
            if (!_grafo.ContainsKey(destino)) CriarVertice(destino);

            if (!_grafo[origem].Contains(destino)) 
            {
                _grafo[origem].Add(destino);
            }
        }

        bool Remove(T vertice)
        {
            if (_grafo.ContainsKey(vertice))
            {
                foreach (var item in _grafo.Values)
                {
                    item.Remove(vertice);
                }

                _grafo.Remove(vertice);

                return true;
            }

            return false;
        }
    }
}
