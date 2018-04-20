let isPrime i =
    let rec testDiv n =
        if (n > (i/2)) then true
        else
            match i%n with
            |0 -> false
            |_ -> n+1 |> testDiv
    if i=1 then false
    else testDiv 2

let rec searchForNthPrime n i =
    match n with
    |0 -> i-2
    |_ -> 
        match isPrime i with
        |true -> searchForNthPrime (n-1) (i+2)
        |false -> searchForNthPrime n (i+2)

isPrime 541
searchForNthPrime 10001 1