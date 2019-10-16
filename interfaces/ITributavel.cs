using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    interface ITributavel //questão 1
    {
        double CalculaTributo();
    }
}
// QUESTÃO 2:
//O que acontece se tentarmos instanciar uma interface?
//ITributavel t = new ITributavel();
//R: Erro de compilação.Interfaces não tem implementação e, logo, não podem ser instanciadas.

//QUESTÃO 3: o código não compila pois toda classe que assina a interface é obrigada a dar uma implementação para essa funcionalidade, se não implementarmos o método da interface, a classe não compilará.
