let isNotEvenlyDivisible i d =
    match i with
    |0 -> true
    |_ ->
        match i%d with
        |0 -> false
        |_ -> true

let rec smallest b i =
    match [1..b] |> List.filter (isNotEvenlyDivisible i) |> List.length with
    |0 -> i
    |_ -> (i+10) |> smallest b

smallest 20 0
