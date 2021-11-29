// Игра "Угадай число"
/* чтобы ПК загадал число в некотором диапазоне от 1 до 100
Далее он предлагает игроку угадать это число.
Игрок вводит некторое число, и ПК отвечает:
1. Правильное ли это число
2. Загаданное число больше, чем введенное.
3. Загаданное число меньше, чем введенное.
После этого игрок делет следующую попытку.
У игрока есть некоторое количество попыток.
Если игрок пторатил все свои попытки, то игра заканчивается.
Если игрок угадал число, но попытки ещё остались, игра также заканчивется.
Alt+Shift+F
*/
/* 1. Определить условия. Какой диапазон для загадывания чисел - мы его задаем, 
формируем рандомно или запрашиваем у пользователя?; 
Опеределиться с количеством попыток - высчитать необходимое 
количество попыток, либо запросить у участника.
2. Загадать число в указанном диапазоне.
3. Начало игры - описываем правила.
4. Запрашиваем у пользователя число. Пользователь вводит некоторое число 
(добавить проверку нештатных ситуаций). Опеределяем как оно соотносится с нашим загаданным и 
даём следующие инструкции игроку. Если пользователь не угадал, то у него сгорает 1 попытка.
5. Игра продолжается пока есть попытки или пока пользователь не угадал число.

int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования.
int createNumber (int leftBound, int rightBound) - загадает число в 
указанном диапазоне и вернет его нам.

bool MakeMove(int SecretNumber, int AttemptpsCount) -  метод, в котором запрограммирован 1 игровой
ход, в результате метод возвращает либо true (угадано чсло, остановка игры), 
либо false (пользователь не угадал).
*/
int SecretNumber = createNumber(1, 100); // int PlayersNumber = requestNumber ();

int createNumber(int leftBound, int rightBound)
{
    return new Random().Next(leftBound, rightBound + 1);
}
Console.WriteLine(SecretNumber); //test

int leftBound = 1; //test of method
int rightBound = 100;
int result112 = createNumber(leftBound, rightBound);
    if (result112 > leftBound && result112 <= rightBound)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Not correct");
    }
int requestNumber()
{
    int requestNumber = 0;
    while (true)
    {
        Console.WriteLine("Guess number from 1 to 100");
        if (int.TryParse((Console.ReadLine()), out int result))
        {
            if (result > 0)
            {
                requestNumber = result;
                Console.Clear();
                break;
            }
        }
        else
        {
            Console.WriteLine("Number did not resolved");
        }
    }
    return requestNumber;
}
int temp = requestNumber();
Console.WriteLine(temp); //test

bool MakeMove (int SecretNumber, int AttemptsCount)
{
    int PlayersNumber = requestNumber();
    if (PlayersNumber == SecretNumber)
        {
            Console.WriteLine($"You guess number ");
            return true;
        }
    else
        {
            AttemptsCount--;
            if (AttemptsCount >0)
            {
                if (PlayersNumber != SecretNumber)
                {
                    Console.WriteLine("You do not guess number");
                    return false;
                }
                else
                {
                    Console.WriteLine("There is no attempts left");
                }
            }
        }           
}

int reqNumb0 = 0;
int AttemptsCount = 6;
for (int i = 0; i < 5; i++)
{
    reqNumb0 = requestNumber();
    bool reqNumb1 = MakeMove (int SecretNumber, int AttemptsCount);
    if (reqNumb1 == true)
    {
        Console.WriteLine("Good-bye");
        break;
    }
}