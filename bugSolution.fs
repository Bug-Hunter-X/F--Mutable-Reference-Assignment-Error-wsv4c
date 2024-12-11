let mutable x = 10
let y = &x

// Correct way to assign a value to the mutable reference
!y <- 20
printfn "%d" !y