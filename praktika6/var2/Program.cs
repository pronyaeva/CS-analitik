using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
  class Person
  {
    //Закрытые поля
    private string name;
    private string secondname;
    private DateTime BDate;

    //Конструктор с параметрами
    public Person(string studentname, string studentsecondname, System.DateTime studentBDate)
    {
      this.name = studentname;
      this.secondname = studentsecondname;
      this.BDate = studentBDate;
    }

    //Конструктор без параметров
    public Person()
    { }

    //Свойство с методами get и set;
    private string stdname;// Свойство типа string для доступа к полю с именем
    public string Name
    {
      get {
        return name;
      }


    }
    private string stdtsecondname;// Свойство типа string для доступа к полю с фамилией
    public string Secondname
    {
      get {
        return secondname;
      }

    }
    DateTime stdBDate// Свойство типа DateTime для доступа к полю с датой рождения
    {
      get {
        return BDate;
      }
    }

    int inststdBDate// Свойство типа int для получения информации и изменения года рождения в закрытом поле типа DateTime
    {
      get {
        return Convert.ToInt32(BDate);
      }

      set {
        BDate = Convert.ToDateTime(value);
      }
    }

    // перегруженная (override) версия виртуального метода string ToString()
    public override string ToString()
    {
      return string.Format("{0} {1}\nDate of birth: {2}", name, secondname, BDate);
    }

    //Виртуальный метод string ToShortString(), который возвращает строку, содержащую только имя и фамилию
    public string ToShortString()
    {
      return "\n" + "Имя: " + name + "\n" + "Фамилия: " + secondname;
    }
    //Cравнить время, необходимое для выполнения операций с элементами одномерного, двумерного прямоугольного
    //и двумерного ступенчатого массивов с одинаковым числом элементов
    //Для этого в методе Main() создать
    //одномерный массив;
    //двумерный прямоугольный массив;
    //двумерный ступенчатый массив.
  }
  //Опеделить тип Frequency - перечисление со значениями Weekly, Monthly, Yearly
  enum Frequency { Weekly, Monthly, Yearly }

  //Опеделить класс Article, который имеет три открытых автореализуемых свойства, доступных для чтения и записи
  class Article
  {
    public

    Person AboutAuthor
    { get; set; }
    string Title { get; set; }
    double Top { get; set; }

    //Конструктор с параметрами типа Person, string, double для инициализации всех свойств класса
    public Article(Person writtername, string header, double rang)
    {
      this.AboutAuthor = writtername;
      this.Title = header;
      this.Top = rang;
    }

    //Конструктор без параметров
    public Article()
    {
      this.AboutAuthor = new Person();
      this.Title = "Header";
      this.Top = 1;
    }

    // перегруженная (override) версия виртуального метода string ToString()
    public override string ToString()
    {
      return string.Format("{0} {1}\nDate of birth: {2}", AboutAuthor, Title, Top);
    }
  }

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

  }
  static class extention
  {
    static public double Average<Article>([Article]

                    this IEnumerable<Article[]> rang,
                    Func<Article[], long> selector,
                    double Top)
    {

      {
        return Top;
      }
    }

  }
  class ArticleAttribute : Attribute
  {
  }
  class Program
  {
    static void Main()
    {

    }
  }
}