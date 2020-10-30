using System;
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
}