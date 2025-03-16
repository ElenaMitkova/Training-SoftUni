int yearFee = int.Parse(Console.ReadLine());
double basketballShoes = yearFee - (yearFee * 0.4);
double basketballClothes = basketballShoes - (basketballShoes * 0.2);
double basketballBall = basketballClothes * 0.25;
double basketballAccessories = basketballBall * 0.2;
Console.WriteLine(yearFee + basketballShoes + basketballClothes + basketballAccessories + basketballBall);