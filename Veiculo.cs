class Veiculo{
  
  private string  Cor;
  private string Marca;
  private string Modelo;
  protected double Valor;
  private double AnoFabricacao;

  public Veiculo(){

  }
  public Veiculo (string c, string m, string mo, double v, int ano){
    Cor = c;
    Marca = m;
    Modelo = mo;
    Valor = v;
    AnoFabricacao = ano;
   }
  
  public double getValor(){
    return Valor;
  }
  public string getCor(){
    return Cor;
  }
  public void setCor(string c){
    Cor = c;
  }

  public string getMarca(){
    return Marca;
  }
  public void setMarca(string m){
    Marca = m;
  }
  public string getModelo(){
    return Modelo;
  }

  public void setModelo(string mo){
    Modelo = mo;
  }

  public virtual double definirValorVeiculo(double CustoFixo){
    Valor = CustoFixo;
    return Valor;
  }
}