// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let rec read_list n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = read_list (n-1)
    Head::Tail

let read_data = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    read_list n

let prog list = 
    let rec recMax list max =
        match list with
        |[] -> max
        |head::tail -> if (max%2=head%2)&&(head>max) then recMax tail head
                                                    else recMax tail max
    match list with
    |[] -> 0
    |h::t -> recMax t h 

let prog1 list = List.max (List.filter (fun el-> el%2=(List.head list) % 2) list) 

[<EntryPoint>]
let main argv = 
    
    printfn "%A" argv
    0 // return an integer exit code
