// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let sum a b = 
    a+b


[<EntryPoint>]
let main argv = 
    let a = 3
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    let c = sum a b
    System.Console.Write(c)
    let z = System.Console.ReadKey()

    0 // return an integer exit code
