Console.WriteLine("введите порядковый номер дня недели");
string? inputLine = Console.ReadLine();
//валидация введенных значений
if(String.IsNullOrEmpty(inputLine)) {
    Console.WriteLine("Вы передали пустое значение");
}
else if (int.Parse(inputLine)>0 && int.Parse(inputLine)<=7) {
    

    string[] daysOfWeek = new string[7];
    daysOfWeek[0] = "понедельник";
    daysOfWeek[1] = "вторник";
    daysOfWeek[2] = "среда";
    daysOfWeek[3] = "четверг";
    daysOfWeek[4] = "пятница";
    daysOfWeek[5] = "суббота";
    daysOfWeek[6] = "воскресенье";

    int inputNumber = int.Parse(inputLine);
    string OutDayOfWeek = daysOfWeek[inputNumber-1];
    Console.WriteLine(OutDayOfWeek);
}
else Console.WriteLine("недопустимый диапазон");
