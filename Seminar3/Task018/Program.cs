// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = false;
bool y = false;
bool f1 = !(x||y);// OR operand
bool f2 = !x && !y; // AND operanf
Console.WriteLine(f1==f2); 
