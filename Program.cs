using SmartEnum.Enums;

//CreditCard creditCardValue = CreditCard.Standard;

////Switch yeni kullanım
//var discount = creditCardValue switch
//{
//    CreditCard.Standard => 0.01,
//    CreditCard.Platinium => 0.1,
//    CreditCard.Premium => 0.2,
//    _ => throw new NotImplementedException()
//};

//CreditCard2 creditCardValue = CreditCard2.FromValue(1);
//var discount = creditCardValue.GetDiscountRate();

//Console.WriteLine($"Credit Card type {creditCardValue} discount: {discount}");


CreditCard3? creditCard3 = CreditCard3.FromName("Standard");
CreditCard3? creditCard4 = CreditCard3.FromValue(3);
Console.WriteLine(creditCard3.Name);
Console.WriteLine(creditCard4.Name);
