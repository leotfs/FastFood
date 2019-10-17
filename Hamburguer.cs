using System;

class Hamburguer : Alimento{
  private float custo=5.2f;
  private int qtdBife = 1;
  private int salada=1;
  private int pao=2;
  private float preco;

  public void Adicional(int bife, int salada){
    this.qtdBife*=bife;
    this.salada*=salada;
  }

  public float Preco(){
    if (qtdBife==1 && salada == 1 && pao == 2)
      preco =8.0f;
    else{
      float precoAdSalada=1f*this.salada;
      float precoAdHamb =2.5f*this.qtdBife;
      preco= 8 + precoAdHamb+precoAdSalada;
    }
    return preco;
  }

  public void SetNome(string name){
    nome = name;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Hamburguer\nPreco Inicial: 8R$\nAdicionais: {0}-saladas {1}-Bifes",salada,qtdBife);
    Console.WriteLine("======================= Preco: {0} =========================",preco);
  }
}