<script>
import { Pie } from 'vue-chartjs'
// import the component - chart you need

export default Pie.extend({
  mounted () {
    // Overwriting base render method with actual data.
    this.renderChart({
      labels: ["Masculino","Feminino"],
      datasets: [
        {
          label: "Sexo",
          
          data: ["50132","56789"]
        }
      ],
      backgroundcolor: ['#000','#fff']
    },)
  }
})
</script>


