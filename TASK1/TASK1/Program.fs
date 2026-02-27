let digits n = //генератор списков
    [ for i in 1 .. n do 
        printf "Введите число: "
        let number = int(System.Console.ReadLine())
        yield abs(number%10) //возвращаем последнюю цифру введенного числа
    ]

[<EntryPoint>]
let main argv = 
    printf "Введите количество чисел: "
    let n = int(System.Console.ReadLine())
    if n > 0 then //проверка на корректность ввода количества
        let list_of_digits = digits n;
        printfn "Последние цифры введенных чисел: %A" list_of_digits
    else
        printfn("Количество не может быть отрицательным или равным нулю!")
    0