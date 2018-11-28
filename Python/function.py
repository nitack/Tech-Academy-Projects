

my_sentence = 'loves the color'

color_list = ['red','blue','green','p!nk','black']

def color_function(name):
    lst = []
    for i in color_list:
        msg = "{0} {1} {2}".format(name,my_sentence,i)
        lst.append(msg)
    return lst


lst = color_function('Ryan')
for i in lst:
    print(i)
