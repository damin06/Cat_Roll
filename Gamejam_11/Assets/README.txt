#그루잠

###깃 병합 요령 :충돌이 일어나지 않으면 그대로 합친다.
*(우리 지금 작업은 충돌이 안일어나면 이상한 거라서 재확인이 필요)   *
</brl>
###충돌이 일어날 경우
```
 Use the added file from (base) 
 Use the added file from (compare) 
 Use the modified file from (base) 
 Use the modified file from (compare)
 Do not include file from (base)
 Do not include file from (compare)
```   

</brl>

>## 번외

> * currentLayout (현재 창 배치), Scene (하이러키 뷰 구성) 은 큰 상관이 없으니 병합하는 사람 마음대로.
 * 우선순위는 위와같다.
 * 우선순위에 따라 둘 중 더 높은 쪽을 누르면 병합에는 문제 없음.
 * 이후 손상된 파일이나 충돌파일이 남을 수도 있는데, 이것은 추가로 조정이 필요.
 * 메인 또는 메인에 준하는 브랜치에서는 씬 정리 하는 것 말고는 작업하지 않기
 * 병합 할 때, origin 으로 시작하는 브랜치(원거리 브랜치)의 경우 한번 들어가서 근거리(?) 브랜치로 해주고 병합해야함. 안그러면 풀리퀘스트가 자동 종료되지 않음.
-----------------------------------------------------------------------------------------