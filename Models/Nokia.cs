namespace DesafioPOO.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Nokia : Smartphone
  {
    public Nokia(string number, string model, string imei, int storage) : base(number, model, imei, storage)
    {
        
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia...");
    }
  }
}