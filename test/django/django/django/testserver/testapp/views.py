from django.shortcuts import render
from .models import InsuranceInfo
import json
from django.http import HttpResponse
def listSize(request):
    data =[{'listSize':len(InsuranceInfo.objects.all())},]
    return HttpResponse(json.dumps(data), content_type='application/json')
def getInsuranceInfo(request):
    data=[]
    postListSize=0
    if request.method=='POST':
        postListSize=request.POST['listSize']
    else:
        postListSize=request.GET['listSize']
    for insuranceInfo in InsuranceInfo.objects.all():
        bunnapDate=insuranceInfo.bunnapData.split('/',1)
        bunnapPremium=insuranceInfo.bunnapPremium.split('/',1)
        
        for i in range(0,5-len(bunnapDate)):
            bunnapDate.append('')
            bunnapPremium.append('0')
        if bunnapPremium[0]=="":
            bunnapPremium[0]=0
        data.append({'contractor':insuranceInfo.contractor,
        'insuredPerson':insuranceInfo.insuredPerson.split('/'),
        'admin':insuranceInfo.admin,
        'SSNumber':insuranceInfo.SSNumber,
        'phoneNumber':insuranceInfo.phoneNumber,
        'homeNumber':insuranceInfo.homeNumber,
        'address':insuranceInfo.address,
        'car':{'carKind':insuranceInfo.carKind,'carNumber':insuranceInfo.carNumber,},
        'insurancePeriod':insuranceInfo.insurancePeriod,
        'installmentDate':{'bunnapDate':bunnapDate,'bunnapPremium':bunnapPremium},
        'premium':insuranceInfo.premium,
        'insuranceKind':insuranceInfo.insuranceKind,
        'insuredPersonSSNumber':insuranceInfo.insuredPersonSSNumber.split('/'),
        'memo':insuranceInfo.memo,
        'profileImage':None,
       },)
    splitData=data[int(postListSize):]




    print("\n\n\n")
    print(json.dumps(splitData))
    return HttpResponse(json.dumps(splitData), content_type='application/json')
def putInsuranceInfo(request):
   
    insure=InsuranceInfo(
    contractor=request.POST['contractor'],
    insuredPerson=request.POST['insuredPerson'],
    admin=request.POST['admin'],
    SSNumber=request.POST['sSNumber'],
    phoneNumber=request.POST['phoneNumber'],
    homeNumber=request.POST['homeNumber'],
    address=request.POST['address'],
    carKind=request.POST['carKind'],
    carNumber=request.POST['carNumber'],
    insurancePeriod=request.POST['insurancePeriod'],
    bunnapData=request.POST['bunnapDate'],
    bunnapPremium=request.POST['bunnapPremium'],
    premium=request.POST['premium'],
    insuranceKind=request.POST['insuranceKind'],
    insuredPersonSSNumber=request.POST['insuredPersonSSNumber'],
    memo=request.POST['memo'],
    profileImage=None,
        )
    insure.save()
    data=[{'flag':true}]
    return HttpResponse(json.dumps(data), content_type='application/json')
def testpage(request):
    postListSize=request.POST['listSize']
    data =[{'insuranceNumber':1,
    'contractor':'홍씨',
    'insuredPerson':['피보험자','피보험자2','피보험자3'],
    'admin':'관리자성명',
    'SSNumber':'981020-1081111',
    'phoneNumber':'010-4444-4444',
    'homeNumber':'02-427-3065',
    'address':'주소',
    'car':{'carKind':'차량종류','carNumber':'차량번호',},
    'insurancePeriod':'20160705',
    'installmentDate':{'bunnapDate':['20160705','20160605','','',''],'bunnapPremium':[1000,1000,0,0,0],},
    'premium':'30000',
    'insuranceKind':'생명보험',
    'insuredPersonSSNumber':['981020-1082888','981020-1082889','981020-2082888'],
    'memo':'시바라라라라라라라라랄토나올꺼같애\n진짜 개그켬이야 모콘괜히한듯',
    'profileImage':None,
   },{'insuranceNumber':2,
    'contractor':'계약자2',
    'insuredPerson':['피보험자','피보험자2','피보험자3'],
    'admin':'관리자성명',
    'SSNumber':'981020-1081111',
    'phoneNumber':'010-4445-4444',
    'homeNumber':'02-427-3065',
    'address':'주소',
    'car':{'carKind':'차량종류','carNumber':'차량번호',},
    'insurancePeriod':'20160705',
    'installmentDate':{'bunnapDate':['20160505','20160605','20160701','',''],'bunnapPremium':[1000,1000,0,0,0],},
    'premium':'20000',
    'insuranceKind':'생명보험',
    'insuredPersonSSNumber':['981020-1082888','981020-1082889','981020-2082888'],
    'memo':'시바라라라라라라라라랄토나올꺼같애\n진짜 개그켬이야 모콘괜히한듯',
    'profileImage':None,
   },]
    
    splitData=data[int(postListSize):]
    print(json.dumps(splitData))
    return HttpResponse(json.dumps(splitData), content_type='application/json')
def testpages(request):
    return HttpResponse("hey this is dummy server LOL do not connect my server.")
