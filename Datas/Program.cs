namespace CSHARP {
  class Datas {
    static void Main(string[] args) {
      //DateTime é um Struct, sempre inicializados com um valor
      
      Console.Clear();
      
      //Data Padrão, com os valores padrãos
      var date = new DateTime();
      Console.WriteLine($"Valor Padrão: {date}");
      Console.WriteLine("---------------------------------");
      //Data Atual
      var date1 = DateTime.Now;
      Console.WriteLine($"Valor Atual: {date1}");
      Console.WriteLine("---------------------------------");

      //É possível passar valores para o Struct DateTime
      var date2 = new DateTime(2024, 12, 15, 9, 57, 21);

      //E obter de forma separada
      Console.WriteLine("Valores Separados");
      Console.WriteLine(date2);
      Console.WriteLine(date2.Year);
      Console.WriteLine(date2.Month);
      Console.WriteLine(date2.Day);
      Console.WriteLine(date2.Hour);
      Console.WriteLine(date2.Minute);
      Console.WriteLine(date2.Second);
      Console.WriteLine(date2.DayOfYear);
      Console.WriteLine("---------------------------------");

      //Formatando uma Data da forma que preferir
      var date3 = DateTime.Now;
      var format = String.Format("{0: hh:mm:ss -- dd/MM/yyyy }", date3);
      Console.WriteLine($"Formatação Personalizada: {format}");
      Console.WriteLine("---------------------------------");


      //Formatações Padrão
      var format1 = String.Format("{0:t}", date3);
      var format2 = String.Format("{0:T}", date3);
      var format3 = String.Format("{0:d}", date3);
      var format4 = String.Format("{0:D}", date3);
      var format5 = String.Format("{0:f}", date3);
      var format6 = String.Format("{0:g}", date3);
      var format7 = String.Format("{0:r}", date3);
      var format8 = String.Format("{0:s}", date3);
      var format9 = String.Format("{0:u}", date3);
      Console.WriteLine($"Formatação Padrão");
      Console.WriteLine(format1);
      Console.WriteLine(format2);
      Console.WriteLine(format3);
      Console.WriteLine(format4);
      Console.WriteLine(format5);
      Console.WriteLine(format6);
      Console.WriteLine(format7);
      Console.WriteLine(format8);
      Console.WriteLine(format9);
      Console.WriteLine("---------------------------------");

      Console.WriteLine("Adicionando Valores a Datas");
      //Em vez de Fazer incrementos como 
      //var newDate = date3.Day + 1;  O Dia pode ser 31 e não temos o dia 32!

      //Então utilizar os métodos Add, para não precisar se preocupar com essa situação
      //O .NET irá calcular automaticamente
      Console.WriteLine($"Data Atual: {date3}");
      Console.WriteLine($"Incrementando Anos: {date3.AddYears(5)}");
      Console.WriteLine($"Incrementando Meses: {date3.AddMonths(16)}");
      Console.WriteLine($"Incrementando Dias: {date3.AddDays(43)}");
    }
  }
}