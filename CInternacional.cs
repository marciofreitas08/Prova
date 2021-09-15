class CInternacional : Veiculo{

 public CInternacional(){

 }
  public override double  definirValorVeiculo(double CustoFixo){
    double valorAtual;
    valorAtual = CustoFixo * 3.0 + 0.6 * CustoFixo + CustoFixo / 5;
    Valor = valorAtual;
    return Valor;
  }
 
  
}