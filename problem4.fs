let rec isPalindrome (s:string) =
    match s.Length with
    |0 | 1 -> true
    |_ -> 
        match s.[0] = s.[s.Length - 1] with
        |true -> isPalindrome ((Array.sub (s.ToCharArray()) 1 (s.Length-2)) |> System.String.Concat) 
        |false -> false

let largestPalindrome maxNumber =
    let current = ref 0
    let rec checkAllPalindromes (a:int) (b:int) =
        if (a*b) |> string |> isPalindrome && (a*b) > !current then current := (a*b)
        match b with
        | 1 -> 
            match a with
            |1 -> 0
            |_ -> checkAllPalindromes (a - 1) maxNumber
        | _ -> checkAllPalindromes a (b-1)
    checkAllPalindromes maxNumber maxNumber |> ignore
    !current


999 |> largestPalindrome
