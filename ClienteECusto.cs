using System;

class Cliente{
  private string nomeCliente;
  private float precoC;

  public void setCliente(string nameCliente){
    nomeCliente = nameCliente;
  }
  public void setPreco(float custoCliente){
    precoC = custoCliente;
  }
  public string getNome(){
    return nomeCliente;
  }
  public float getPreco(){
    return precoC;
  }
}
