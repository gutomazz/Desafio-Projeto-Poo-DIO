using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
public class Program {
    public static void Main(){
        Iphone i1 = new("81988888", "1008524c5xx", "iphone 12", 128);
        i1.Ligar();
        i1.ReceberLigacao();
        i1.InstalarAplicativo("zapzap");

        Nokia a1 = new("8198544657", "1554c558x4v", "Nokia a1", 64);
        a1.Ligar();
        a1.ReceberLigacao();
        a1.InstalarAplicativo("Jogo do tigrinho");

    }
}