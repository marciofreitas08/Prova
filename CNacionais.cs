class CNacional : Veiculo{
  
  public CNacional(){

  }
  public override double definirValorVeiculo(double CustoFixo){
    double valorAtual;
    valorAtual = CustoFixo * 1.5 + 0.2 * CustoFixo + CustoFixo / 10;
    Valor = valorAtual;
    return Valor;
  }

}