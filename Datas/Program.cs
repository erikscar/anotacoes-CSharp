using System.Globalization;

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


      //Comparações de Datas
      //As Datas podem ser comparadas porém deve tomar cuidado

      var date10 = DateTime.Now;
      Console.WriteLine("Comparação de Datas");

      if (date10 == DateTime.Now) {//Isso NUNCA vai ser igual 
      //A Primeira Data sempre será criada um pouco antes da condição do IF
      //Mesmo que por segundos, ou seja nunca será igual
        Console.WriteLine("É Igual");
      } else {
        Console.WriteLine("É Diferente");
      }

      if(date10.Date == DateTime.Now.Date) { //Comparando apenas as Datas será igual
           Console.WriteLine("É Igual");
      } else {
        Console.WriteLine("É Diferente");
      } 
      Console.WriteLine("---------------------------------");


      //Culture Info, existem várias
      var en = new CultureInfo("en-US");
      var pt = new CultureInfo("pt-PT");
      var cn = new CultureInfo("zh-CHS");
      var atual =  CultureInfo.CurrentCulture; //Idioma do PC Atual

      //Em vez de usar o Format, usar o toString direto para formatar datas em uma linguagem
      Console.WriteLine("Diferentes Idiomas para Datas");
      Console.WriteLine(DateTime.Now.ToString("D", en));
      Console.WriteLine(DateTime.Now.ToString("D", pt));
      Console.WriteLine(DateTime.Now.ToString("D", cn));
      Console.WriteLine(atual);
      Console.WriteLine("---------------------------------");

     //TimeZones, mais recomendado utilizar
      
      var dateTime = DateTime.UtcNow; //Horário GLOBAL, RECOMENDADO SEMPRE USAR DEPOIS FORMATAR
      Console.WriteLine("TIMEZONES ");
      Console.WriteLine(dateTime);
      Console.WriteLine(dateTime.ToLocalTime()); //Salvar na Hora Local

      //Buscar um TIMEZONE de um lugar específico
      var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      Console.WriteLine(timezoneAustralia);

      var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
      Console.WriteLine(horaAustralia);

      //Obter todos os Timezones

      var timezones = TimeZoneInfo.GetSystemTimeZones();
      foreach (var timezone in timezones) {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
        Console.WriteLine("-------------");
      }

      //TIMESPAN PARA SABER FRAÇÕES DE HORA
      var timespan = new TimeSpan();
      var timespanNanoSeconds = new TimeSpan(1);
      Console.WriteLine(timespanNanoSeconds);
    } 
  }
}