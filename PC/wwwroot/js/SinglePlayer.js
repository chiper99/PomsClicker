window.addEventListener("load", function () {
    const clickApple = document.querySelector('#clickApple');
    const scoreCounterElement = this.document.querySelector('#scoreCounter');
    
    const EvaElement = this.document.querySelector('#EvaElement');
    const NewtonElement = this.document.querySelector('#NewtonElement');
    const JobsElement = this.document.querySelector('#JobsElement');

    const EvaElementCounter = this.document.querySelector('#EvaElementCounter');
    const NewtonElementCounter = this.document.querySelector('#NewtonElementCounter');
    const JobsElementCounter = this.document.querySelector('#JobsElementCounter');

    const EvaCostElement = this.document.querySelector('#EvaCostElement');
    const NewtonCostElement = this.document.querySelector('#NewtonCostElement');
    const JobsCostElement = this.document.querySelector('#JobsCostElement');

    var EvaCost = EvaCostElement.innerHTML;
    var NewtonCost = NewtonCostElement.innerHTML;
    var JobsCost = JobsCostElement.innerHTML;
    
    var EvaCount = EvaElementCounter.innerHTML;
    var NewtonCount = NewtonElementCounter.innerHTML;
    var JobsCount = JobsElementCounter.innerHTML;
    
        var score = scoreCounterElement.innerHTML;

    EvaElement.addEventListener('click',function(){
        
        if(score >= EvaCost){
            score = score - EvaCost;
            EvaCount++;
            EvaElementCounter.innerHTML = EvaCount;
            scoreCounterElement.innerHTML = score;
            EvaCost = Math.round(EvaCost * 1.2);
            EvaCostElement.innerHTML = EvaCost;
        }
    });

    NewtonElement.addEventListener('click',function(){
        if(score >= NewtonCost){
            score = score - NewtonCost;
            NewtonCount++;
            NewtonElementCounter.innerHTML = NewtonCount;
            scoreCounterElement.innerHTML = score;
            NewtonCost = Math.round(NewtonCost * 1.2);
            NewtonCostElement.innerHTML = NewtonCost;
        }
    });

    JobsElement.addEventListener('click',function(){
        if(score >= JobsCost){
            score = score - JobsCost;
            JobsCount++;
            JobsElementCounter.innerHTML = JobsCount;
            scoreCounterElement.innerHTML = score;
            JobsCost = Math.round(JobsCost * 1.2);
            JobsCostElement.innerHTML = JobsCost;
        }
    });

    clickApple.addEventListener('click', function(){
        score++;
        scoreCounterElement.innerHTML = score;
    });

    function tickHandler(){
        score = parseInt(score)  + parseInt(EvaCount) * 1 + parseInt(NewtonCount) * 5 + parseInt(JobsCount) * 10;
        scoreCounterElement.innerHTML = score;
    } 

    function postData() {
        let formData = new FormData();
        formData.append('EvaCount', EvaCount);
        formData.append('EvaCost', EvaCost);
        formData.append('NewtonCount', NewtonCount);
        formData.append('NewtonCost', NewtonCost);
        formData.append('JobsCount', JobsCount);
        formData.append('JobsCost', JobsCost);
        formData.append('Score', score );

        fetch('/SinglePlayer/postData', {
            method: 'POST',
            body: formData
        }).then(function (response) {
                var a = response.status
        }).catch((e) => {
            showError('Assignment save failed');
        });
    }

    setInterval(postData,10000);

    setInterval(tickHandler,500);

});

function openNav()
          {
            document.getElementById('centralmenu').style.display = "block";
          }
          function closeNav()
          {
            document.getElementById('centralmenu').style.display = "none";
          }


window.addEventListener("close", function( event ) {

    event.preventDefault();
  }, false);
