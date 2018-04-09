let rec factor (n:int64) (i:int64) =
    match n%i with
    |0L -> factor (n/i) i |> List.append [i]
    |_ -> if i>n then [] else factor n (i+1L)

factor 600851475143L 2L |> List.last 
