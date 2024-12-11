# F# Mutable Reference Assignment Bug

This repository demonstrates a common error in F# when working with mutable references and the `<-` assignment operator.

The bug arises from incorrectly attempting to directly assign a value to a reference cell using `<-`.

## Bug Description
The `bug.fs` file contains code that attempts to assign a value directly to a mutable reference using the `<-` operator.  This results in a compile-time error.

## Solution
The `bugSolution.fs` file provides the corrected code, showing the correct way to modify the value held by the mutable reference using the dereference operator `!`.