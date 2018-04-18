let rec diffSumSquare (n:int list) =
    match n with
    |head :: tail -> head * (List.sum tail) + (diffSumSquare tail)
    |_ -> 0

2 * diffSumSquare [1..100]
