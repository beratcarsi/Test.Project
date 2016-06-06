using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Test.Project.Tests
{
    [TestFixture]
    public class ExpressionTreeTest
    {
        [Test]
        public void expression_tree_test()
        {
            // İfadeyi tanımla ve İfade Ağacına çevir.
            Expression<Func<int, int, bool>> agacYapisi = (a, b) => a == b;

            // Gövdeyi (body) al (a == b).
            BinaryExpression govde = (BinaryExpression)agacYapisi.Body;

            // Gövdeden sol (left) tarafı al (a'yı alır).
            ParameterExpression sol = (ParameterExpression)govde.Left;

            // Gövdeden sağ (right) tarafı al (b'yi alır).
            ParameterExpression sag = (ParameterExpression)govde.Right;

            // BinaryExpression ve ParameterExpression sınıflarının
            // bazı özelliklerini göster bakalım.

            Console.Write("Gövde : ");
            Console.WriteLine(govde.ToString());

            Console.Write("Sol : ");
            Console.WriteLine(sol.ToString());

            Console.Write("Düğüm tipi (işlem) : ");
            Console.Write(govde.NodeType.ToString());

            Console.Write("Sağ : ");
            Console.WriteLine(sag.ToString());
        }

        [Test]
        public void expression_tree_factorial_test()
        {
            Console.Write("CSharpFact(5) = ");
            Console.WriteLine(CSharpFact(5).ToString());
            Console.Write("ETFact(5) = ");
            Console.WriteLine(ETFact()(5).ToString());

            // Üstteki ETFact()(5) ifadesini şu şekilde de yazabilirsiniz.
            // var ETFactFonksiyon = ETFact();
            // veya fonksiyonun tam tipiyle delege tanımlayarak
            // Func<int, int> ETFactFonksiyon = ETFact();
            // daha sonra alttaki gibi çalıştır
            // Console.WriteLine(ETFactFonksiyon(5).ToString());
        }


        // C# Factorial (C# ile faktöriyel)
        static int CSharpFact(int value)
        {
            int result = 1;
            while (value > 1)
            {
                // result değişkeninin son değerini value ile çarp ve value değişkeninin değerini bir azalt
                result *= value--;
            }
            return result;
        }

        // Expression Tree Factorial (İfade ağacı ile faktöriyel)
        static Func<int, int> ETFact()
        {
            // int tipinde, value isimli bir parametre ifadesi oluştur.
            ParameterExpression value = Expression.Parameter(typeof(int), "value");
            // int tipinde result isimli bir parametre ifadesi oluştur. (yerel değişken olarak kullanılacak)
            ParameterExpression result = Expression.Parameter(typeof(int), "result");
            // Döngüden dışarı çıkmak için goto ile gidilecek bir etiket label oluştur.
            LabelTarget label = Expression.Label(typeof(int));

            // Yöntemin (fonksiyonun) gövdesini oluştur (ifade bloğu başı).
            BlockExpression block = Expression.Block(
                // Yerel değişkeni gövdeye ekle.
                new[] { result },
                // Yerel değişkene 1 sabitini ata (result = 1).
                Expression.Assign(result, Expression.Constant(1)),
                // Bir döngü ekle (while).
                Expression.Loop(
                    // Döngünün içine bir şart bloğu ekle (if ...)
                    Expression.IfThenElse(
                    // Şart bloğunun şartı olarak value değişkeninin 1'den büyük olması şartını ekle ( ... value > 1)
                    Expression.GreaterThan(value, Expression.Constant(1)),
                    // Şart doğruysa result değişkeninin değerini value parametresinin son değeriyle çarp ve
                    // result değişkenine ata (result *= value)
                    Expression.MultiplyAssign(result,
                        // Çarpmadan sonra value değişkeninin değerini 1 azalt ( ...value--)
                        Expression.PostDecrementAssign(value)),
                        // Eğer şart doğru değilse label isimli etikete atla / döngüden çık (... else goto label:)
                        Expression.Break(label, result)
                    ), // Şart bloğu sonu.
                       // Atlanacak etiket.
                    label

                ) // Döngü sonu
            ); // İfade bloğu sonu.

            // İfade Ağacını derle ve bir delege olarak döndür.
            return Expression.Lambda<Func<int, int>>(block, value).Compile();
        }

    }

}