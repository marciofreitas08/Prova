using System;
using System.Collections.Generic;
class Concessionaria {

  private string localizacao;
  private string gerentePrincipal;
  private int anoFundacao;
  private List<Veiculo> Carrosdisponiveis = new List<Veiculo>();  

  public Concessionaria(){

  }
  public Concessionaria(string c, string g, int anoF, List<Veiculo> ca){
    localizacao = c;
    gerentePrincipal = g;
    anoFundacao = anoF;
    Carrosdisponiveis  = ca;
  }

  public void adicionarCarro(Veiculo v){
    Carrosdisponiveis.Add(v);
  }
 
  
}