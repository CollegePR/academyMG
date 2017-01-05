from academyMGS.models import *
import json
from django.http import HttpResponse


def addStudent(request):
    data = [{'status': False, 'flag': False}]
    name = ""
    sex = True
    phone_num = ""
    address = ""
    school_name = ""
    grade = 0
    school_class = 0
    status_of_sign = 2


    try:
        if request.method == "POST":
            name = request.POST.get('name')
            sex = request.POST.get('sex')
            phone_num = request.POST.get('phone_num')
            address = request.POST.get('address')
            school_name = request.POST.get('school_name')
            grade = request.POST.get('grade')
            school_class = request.POST.get('school_class')
            status_of_sign = request.POST.get('status_of_sign')
            print(name)
            print(sex)
            print(phone_num)
            print(address)
            print(school_name)
            print (school_class)
            print (grade)
            print (status_of_sign)


        else:
            print("try문 else문진입")
            return HttpResponse(json.dumps(data), content_type='application/json')

        student = Student(
            name=name,
            sex=sex,
            phone_num=phone_num,
            address=address,
            school_name=school_name,
            school_class=school_class,
            grade=grade,
            status_of_sign=status_of_sign,


        )
        student.save()
        data = [{'status': True, 'flag': True}]
    except:
        print("예외문진입")
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')
