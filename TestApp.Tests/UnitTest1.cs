namespace TestApp.Tests;

public class UnitTest1
{
    [Fact]
    public void 最初のテスト()
    {
        //引数は、期待値、実際の値の順序で指定する
        int intValue = 123;
        Assert.Equal(123, intValue);

        string stringValue = "AAA";
        Assert.Equal("AAA", stringValue);

        //string stringValueB = "AAAX";
        //Assert.Equal("AAA", stringValueB);

    }


    [Fact]
    public void boolのテスト()
    {
        Assert.True(true);
        Assert.False(false);

        var vm = new ProductViewModel();
        Assert.True(vm.IsCheked);
        Assert.False(vm.IsReadOnly);
    }


    [Fact]
    public void 文字のテスト()
    {
        var vm = new ProductViewModel();
        vm.Price = 123;
        Assert.Equal("123円", vm.PriceText);

        //StartsWith
        //文字列が指定された文字列で始まることを検証します。
        Assert.StartsWith("Ab", "Abc123");

        //EndsWith
        //文字列が指定された文字列で終わることを確認します。
        Assert.EndsWith("123", "Abc123");

        //大文字と小文字の違いを無視する
        //Assert.Equal("Abc123", "AbC123");//NGになる
        Assert.Equal("Abc123", "AbC123", ignoreCase: true);

        //大文字が含まれているとこのテスト
        //Contains
        Assert.Contains("c1", "Abc123");
    }

    [Fact]
    public void 正規表現のテスト()
    {
        //正規表現
        //「文字列のパターンマッチングを行うための表記法」
        //数字のみ
        //「＾［０−９］と書ける。
        //Assert.Matches("^[0-9]+$", "12345"); //OK
        //Assert.Matches("^[0-9]+$", "123A45"); //NG
        Assert.DoesNotMatch("^[0-9]+$", "123A45"); //OK


        //英字のみ（大文字・小文字を区別しない）
        //＾［A -Za-z］＋＄
        //Assert.Matches("^[0-9]+$", "12345"); //OK
        //Assert.Matches("^[0-9]+$", "Abc1"); //NG
        Assert.Matches("^[A-Za-z]+$", "Abc");
    }

    [Fact]
    public void 数値のテスト()
    {
        var vm = new ProductViewModel();
        vm.Price = 123;
        Assert.Equal(123, vm.Price);
        Assert.NotEqual(0, vm.Price);

        Assert.InRange(vm.Price, 100, 200);
        Assert.NotInRange(vm.Price, 124, 200);
    }


}