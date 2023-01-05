#1- Bir listeyi düzleştiren (flatten) fonksiyon yazın. Elemanları birden çok katmanlı
#listelerden ([[3],2] gibi) oluşabileceği gibi, non-scalar verilerden de oluşabilir. 
#Örnek olarak:
#input: [[1,'a',['cat'],2],[[[3]],'dog'],4,5]
#output: [1,'a','cat',2,3,'dog',4,5]

liste =[[ 1, 'a', ['elma'], 2], [ [[3] ],'armut'], 4 , 5]
liste_eleman = []
def flatten(l):
    for sublist in l:
        if type(sublist)== list:
            flatten(sublist)
        else:
            liste_eleman.append(sublist)
    return liste_eleman
print(flatten(liste))

#2- Verilen listenin içindeki elemanları tersine döndüren bir fonksiyon yazın.
#Eğer listenin içindeki elemanlar da liste içeriyorsa onların elemanlarını da 
#tersine döndürün. Örnek olarak:
#input: [[1, 2], [3, 4], [5, 6, 7]]
#output: [[[7, 6, 5], [4, 3], [2, 1]]

liste = [[1, 2], [3, 4], [5, 6, 7]]
def reverse_list(l):
    l.reverse()
    for sublist in l:
        if type(sublist) == list:
            reverse_list(sublist)

reverse_list(liste)
print(liste)
