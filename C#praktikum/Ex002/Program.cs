// Игра "Угадай число"
/* чтобы ПК загадал число в некотором диапазоне от 1 до 100
Далее он предлагает игроку угадать это число.
Игрок вводит некоторое число, и ПК отвечает:
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

bool MakeMove(int createNum, int AtrequestNumtpsCount) -  метод, в котором запрограммирован 1 игровой
ход, в результате метод возвращает либо true (угадано чсло, остановка игры), 
либо false (пользователь не угадал).
*/
//int createNum = createNumber(1, 100); // int PlayersNumber = requestNumber ();

int createNumber(int leftBound, int rightBound)
{
    return new Random().Next(leftBound, rightBound + 1);
}


int leftBound = 1; //test of method
int rightBound = 100;
int createNum = createNumber(leftBound, rightBound);

int requestNumber()
{
    int requestNumber = 0;
    while (true)
    {
        Console.WriteLine("Guess number from 1 to 100");
        if (int.TryParse((Console.ReadLine()), out int result))
        {
            if (result > 0 && result < 101)
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
int requestNum = requestNumber();

    if (requestNum == createNum) //(createNum > leftBound && createNum <= rightBound)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Not correct");
    }
//Console.WriteLine(requestNum); //test
//Console.WriteLine(createNum); //test
int attemptsCount = 6;
bool MakeMove (int createNum, int attemptsCount)
{
    int PlayersNumber = requestNumber();
    if (PlayersNumber == createNum)
        {
            Console.WriteLine($"You guess number ");
            return true;
        }
    else
        {
            attemptsCount--;
            if (attemptsCount >0)
            {
                if (PlayersNumber != createNum)
                {
                    Console.WriteLine("You do not guess number");
                    return false;
                }
                else
                {
                    Console.WriteLine("There is no attempts left");
                    return false;
                }
            }
        }           
}

int reqNumb0 = 0;

for (int i = 0; i < 5; i++)
{
    reqNumb0 = requestNumber();
    bool reqNumb1 = MakeMove (createNum, attemptsCount);
    if (reqNumb1 == true)
    {
        Console.WriteLine("Good-bye");
        break;
    }
}
MakeMove(createNum, attemptsCount);