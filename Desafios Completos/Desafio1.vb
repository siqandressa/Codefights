Function nontransitiveDice(dices As List(Of List(Of Integer))) As Boolean 
    
    dim i,j, d1_1X2, d2_1X2, d2_2X3, d3_2X3, d3_1X3, d1_1X3 As Integer=0
    dim dice1, dice2, dice3 as List(Of Integer)
    dim result as boolean = false
    
    result = false
    dice1=dices(0)
    dice2=dices(1)
    dice3=dices(2)
    
    for i =0 to 5
    for j=0 to 5
    if dice1(i)>dice2(j)then
        d1_1X2+=1
    else
        d2_1X2+=1
    end if
    if dice2(i)>dice3(j) then
        d2_2X3+=1
    else
        d3_2X3+=1
    end if
    if dice1(i)>dice3(j) then
        d1_1X3+=1
    else
        d3_1X3+=1
    end if
next
    next

if ((d1_1X2 > 18 and d2_2X3 >18 and d3_1X3>=18) or (d2_1X2 > 18 and d3_2X3 >18 and d1_1X3>=18)) then
        result = true
end if

Console.WriteLine(result)
return result
End Function
