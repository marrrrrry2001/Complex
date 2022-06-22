//  класс комплексных чисел
Complex kock = new Complex(0, 1);
Complex ass = new Complex(0, 1);
Complex Jora = ass.Mult(kock);
// System.Console.WriteLine(ass.Angle());
// System.Console.WriteLine(ass.Abs());
System.Console.WriteLine($"{Jora.Real()}, {Jora.Imag()}");

class Complex
{
  public Complex(double real, double im)
  {
    this.real = real;
    this.im = im;
  }
  private double real, im;

  public double Real()
  {
    return real;
  }

  public double Imag()
  {
    return im;
  }

  public double Abs()
  {
    return Math.Sqrt(real * real + im * im);
  }

  public double Angle()
  {
    return Math.Atan(im / real);
  }

  public Complex Sum(Complex z)
  {
    var r = this.Real() + z.Real();
    var i = this.Imag() + z.Imag();
    var obj = new Complex(r, i);
    return obj;
  }

  public Complex Diff(Complex z)
  {
    var r = this.Real() - z.Real();
    var i = this.Imag() - z.Imag();
    var obj = new Complex(r, i);
    return obj;
  }

  public Complex Mult(Complex z)
  {
    var r = this.Real() * z.Real() - this.Imag() * z.Imag();
    var i = this.Real() * z.Imag() + this.Imag() * z.Real();
    var obj = new Complex(r, i);
    return obj;
  }

  public Complex Devide(Complex z)
  {
    if (Math.Pow(z.Real(), 2) + Math.Pow(z.Imag(), 2) == 0)
    {
      throw new Exception("Простите, вы обосрались");
    }
    var a = this.Real();
    var b = Imag();
    var c = z.Real();
    var d = z.Imag();

    var r = (a * c + b * d) / (c * c + d * d);
    var i = (b * c - a * d) / (c * c + d * d);
    var obj = new Complex(r, i);
    return obj;

  }

}

