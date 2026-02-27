let rec minimal_digit number min = //рекурсивная функция для вычисления минимальной цифры числа
    let  newmin = min
    if number = 0 then 
        newmin
    else 
    if min>(number%10) then
         minimal_digit (number/10) (number%10)
    else
        minimal_digit (number/10) min

[<EntryPoint>]
let main argv =
    printf "Введите натуральное число: "
    let num = int(System.Console.ReadLine())
    if num > 0 then //проверка на корректность ввода
        let min = minimal_digit num 9
        printfn "Минимальная цифра числа %d: %d" num min
    else
        printfn "Число должно быть натуральным!"
    0