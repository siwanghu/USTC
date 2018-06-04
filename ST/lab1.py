# -*- coding:utf-8 -*-
test=["0","9","9.0","9.23","12","12.0","12.5","12.37",\
      "18.09","102.87","1000","1000.3","1007","100700.58"]

format_word = ["分", "角", "元",\
               "拾","百","千","万",\
               "拾","百","千","亿",\
               "拾","百","千","万",\
               "拾","百","千","兆"]

format_num = ["零","壹","贰","叁","肆",\
              "伍","陆","柒","捌","玖"]

def test_parse():
    for input_str in test:
        print("------------------------------------------")
        print(input_str," : ",parse2chinese(input_str))

def parse2chinese(change_number):
    if type(change_number) == str:
        if '.' in change_number:
            try:    
                change_number = float(change_number)
            except: 
                raise ValueError
        else:
            try:   
                change_number = int(change_number)
            except: 
                raise ValueError
    if type(change_number) == float:
        real_numbers = []
        for i in range(len(format_word) - 3, -3, -1):
            if change_number >= 10 ** i or i < 1:
                real_numbers.append(int(round( change_number/( 10**i ), 2)%10))
    elif isinstance(change_number, (int)):
        real_numbers = [ int( i ) for i in str( change_number ) + '00' ]
    else:
        raise ValueError
    flag = 0                      
    start = len(real_numbers) - 3
    change_words = []
    for i in range(start, -3, -1): 
        if 0 != real_numbers[start-i] or len(change_words) == 0:
            if flag:
                change_words.append(format_num[0])
                flag = 0
            change_words.append( format_num[ real_numbers[ start - i ] ] )
            change_words.append(format_word[i+2])

        elif 0 == i or (0 == i%4 and flag < 3):    
            change_words.append(format_word[i+2])
            flag = 0
        else:
            flag += 1
    if change_words[-1] not in ( format_word[0], format_word[1]):
        change_words.append("整")
    return "人民币"+''.join(change_words)

if __name__ == "__main__":
    test_parse()