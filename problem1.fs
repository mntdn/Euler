let isMultipleOf3Or5 i = (i%3 = 0) || (i%5 = 0)
let a = [1..999] |> List.filter isMultipleOf3Or5 |> List.sum
