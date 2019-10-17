using System;

class Bebidas : Alimento {
  private float preco;
  private float qtd;
  private string tipo;
  private float custo;

  private void EscolherTipo(string tipo){

    if (tipo == "Refrigerante") {
      this.tipo = tipo;
      this.preco= 5;
      this.custo = 3.0f;
    }else if (tipo == "Suco") {
      this.tipo = tipo;
      this.preco= 8.5f;
      this.custo = 5.3f;
    }else if(tipo == "Cerveja"){
      this.tipo = tipo;
      this.preco= 8.5f;
      this.custo = 4;
    }
  }

  private void Quantidade(float qtd){
    this.qtd=qtd;
  }

  public void SetNome(string tipo){
    nome = tipo;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Bebida\n");
    Console.WriteLine("======================= Preco: {0} =========================",preco);
  }
}