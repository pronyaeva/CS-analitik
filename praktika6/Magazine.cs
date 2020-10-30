using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2
{
  //Опеделить класс Magazine, который имеет пять закрытых полей
  class Magazine
  {
    private string title; //закрытое поле типа string c названием журнала
    private Frequency periodicity; //закрытое поле типа Frequency с информацией о периодичности выхода журнала
    private DateTime RDate; //закрытое поле типа DateTime c датой выхода журнала
    private int circulation; //закрытое поле типа int с тиражом журнала
    private Article[] list; //закрытое поле типа Article [] со списком статей в журнале

    //конструктор с параметрами типа string, Frequency, DateTime, int для инициализации соответствующих полей класса

    private Magazine(string header, Frequency rhythm, DateTime publicationdate, int quantity)
    {
      this.title = header;
      this.periodicity = rhythm;
      this.RDate = publicationdate;
      this.circulation = quantity;
    }

    //конструктор без параметров, инициализирующий поля класса значениями по умолчанию
    private Magazine()
        : this("Leonardo da Vinci", new Frequency(), new DateTime(), 10000)
    { }

    public Magazine(string title, Frequency periodicity, DateTime rDate, int circulation, Article[] list, string header, Frequency rhythm) : this(title, periodicity, rDate, circulation)
    {
      this.list = list;
      this.header = header;
      this.rhythm = rhythm;
    }

    //В классе Magazine определить свойства c методами get и set:
    private string header;// Свойство типа string для доступа к полю с названием журнала

    public string GetName()
    {
      return title;
    }
    private Frequency rhythm;// Свойство типа string для доступа к полю с информацией о периодичности выхода журнала
    public Frequency Periodicity
    {
      get {
        return periodicity;
      }

    }
    DateTime publicationdate// Свойство типа DateTime для доступа к полю с датой выхода журнала
    {
      get {
        return RDate;
      }
    }

    int quantity// Свойство типа int доступа к полю с тиражом журнала
    {
      get {
        return circulation;
      }
    }

    // Cвойство типа Article*+ для доступа к полю со списком статей
    public Article[] Name => list;

    //Cвойство типа double ( только с методом get), в котором вычисляется среднее значение рейтинга в списке статей
    public double Average<Article>([Article]
                    this IEnumerable<Article[]> rang,
                        Func<Article[], long> selector)
    {
      if (rang is null)
      {
        throw new ArgumentNullException(nameof(rang));
      }

      {
        double Top = 0;
        return Top;
      }
    }
  }
}