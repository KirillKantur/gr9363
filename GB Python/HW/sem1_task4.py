# Задача 4: 
# Петя, Катя и Сережа делают из бумаги журавликов. 
# Вместе они сделали S журавликов. 
# Сколько журавликов сделал каждый ребенок, 
# если известно, что Петя и Сережа сделали одинаковое
# количество журавликов, а Катя сделала в два раза больше журавликов,
# чем Петя и Сережа вместе?

s = int(input("введите число кратное 6: "))
x = s//6
sum_ser = x
sum_pet = x
sum_kat = x*4
print("количество журавлев которые сделал Сершей",sum_ser,
      "количество журавлей кторое сделал Петя",sum_pet,
      "количество журавлей которые сделала Катя",sum_kat)