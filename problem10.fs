let isPrime (i:int64) =
    let rec testDiv n =
        if (n > (i |> float |> sqrt)) then true
        else
            match (float i)%n with
            |0.0 -> false
            |_ -> n+1.0 |> testDiv
    if i=1L then false
    elif i=2L then true
    else testDiv 2.0

let sumPrimesUnderN' n =
    [2L..n-1L] |> List.filter isPrime |> List.sum

#time
sumPrimesUnderN' 2000000L
#time