List.append [1] [2]

let rec fibo limit a:int list =
    match limit with
    |0 -> a
    |_ -> if a.[a.Length-1] > limit then a else List.append a [a.[a.Length-2] + a.[a.Length-1]] |> fibo (limit-1) 

fibo 50 [1;2]

// no 