from academyMGS.models import *
import json
from django.http import HttpResponse


def addStudent(request):
    data = [{'flag': False}]
    name = ""
    sex = True
    phone_num = ""
    address = ""
    school_name = ""
    grade = 0
    school_class = 0
    status_of_sign = 0
    date_of_admission = ""
    date_of_readdmission = ""
    date_of_exit = ""
    birthday = ""
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
            date_of_admission = request.POST.get('date_of_admission')
            date_of_readdmission = request.POST.get('date_of_readdmission')
            date_of_exit = request.POST.get('date_of_exit')
            birthday = request.POST.get('birthday')


        else:
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
            date_of_admission = date_of_admission,
            date_of_readdmission = date_of_readdmission,
            date_of_exit = date_of_exit,
            birthday = birthday,
        )
        student.save()
        data = [{'flag': True}]
    except:
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')
