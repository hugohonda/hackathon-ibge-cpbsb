<template>
  <div class="home">
    <div class="mdl-layout mdl-js-layout mdl-layout--fixed-header">
      <header class="home-header mdl-layout__header">
        <div class="mdl-layout__header-row">
          <!-- Title -->
          <span class="home-header-title mdl-layout-title">{{ title }}</span>
          <!-- Add spacer, to align navigation to the right -->
          <div class="mdl-layout-spacer"></div>
          <!-- Navigation. We hide it in small screens. -->
          <nav class="mdl-navigation mdl-layout--large-screen-only">
            <a class="mdl-navigation__link" href="">Cadastro</a>
            <a class="mdl-navigation__link" href="">Login</a>
          </nav>
        </div>
      </header>
      <div class="home-drawer mdl-layout__drawer">
        <span class="mdl-layout-title">{{ title }}</span>
        <nav class="mdl-navigation">
          <a class="mdl-navigation__link" href="">Cadastro</a>
          <a class="mdl-navigation__link" href="">Login</a>
        </nav>
      </div>
      <main class="mdl-layout__content">
        <div class="home-main-section mdl-typography--text-center">
          <div class="logo-font home-slogan">Abre Aqui</div>
          <div class="logo-font home-sub-slogan">Onde seu negócio dá certo!</div>
          <div class="input-box-container">
            <input-box :text="'Digite sua localização'" :icon="'location_on'"></input-box>
          </div>
        </div>
      </main>
    </div>
  </div>
</template>

<script>
import InputBox from '@/components/InputBox'
import PlaceInput from 'vue-google-maps'
import axios from 'axios'

export default {
  name: 'home',
  components: {
    InputBox
  },
  data () {
    return {
      title: 'Abre Aqui',
      vm: {
        searchPlace: '',
        location: {},
        posts: [],
        errors: []
      }
    }
  }
}
</script>

<style lang="scss" scoped>

.home-header {
  overflow: visible;
}

.home-header .material-icons {
  color: #fff !important;
}

.home-header .mdl-layout__drawer-button {
  background: transparent;
  color: #fff;
}

.home-header .mdl-navigation__link {
  color: #fff;
  font-weight: 700;
  font-size: 14px;
}

  .home-header-title {
    color: #fff;
    font-weight: 700;
    font-size: 24px;
  }

.logo-font {
  font-family: 'Roboto', 'Helvetica', 'Arial', sans-serif;
  line-height: 1;
  color: #FFF;
  font-weight: 500;
}

.home-slogan {
  color: #ffffff;
  font-size: 80px;
  padding-top: 80px;
}

.home-sub-slogan {
  color: #ffffff;
  font-size: 41px;
  padding-top: 24px;
}

.home-main-section {
  position: relative;
  height: 800px;
  width: auto;
  background-color: #f3f3f3;
  background: url('../assets/ipanema-up.png') center 30% no-repeat;
  background-size: cover;
}

.input-box-container {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  align-content: center;
  align-items: center;
  justify-content: space-around;
  padding: 2em;
  margin-top: 2em;
}


</style>
