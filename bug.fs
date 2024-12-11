let mutable x = 10
let y = &x

//This will throw an error because you cannot directly assign a value to a reference using the <- operator.
!y <- 20