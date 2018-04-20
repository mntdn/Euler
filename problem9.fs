
let rec unique (l:int list list) =
    match l with
    |head::tail -> 
        match List.tryFind (fun x -> x = head) tail with
        |Some value -> unique tail
        |None -> List.append [head] (unique tail)
    |[] -> []

let findAllTripletsForSum s =
    let l = seq {for i in 1..s-1 do
            for j in 1..s-1 do
                for k in 1..s-1 do
                    if (i+j+k = s) && (i <> j && j <> k && i <> k) && ([i;j;k] |> List.sort |> List.map (fun x -> x*x) |> (fun t ->  t.[0] + t.[1] = t.[2])) then yield [i;j;k] |> List.sort }
    l |> Seq.toList |> unique

findAllTripletsForSum (1000) |> List.length

200L+375L+425L