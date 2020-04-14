// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import Antd from 'ant-design-vue'
import 'ant-design-vue/dist/antd.css'
import router from './router'
import { Button, message } from 'ant-design-vue';

Vue.config.productionTip = false

Vue.component(Button.name, Button);
Vue.component(Button.Group.name, Button.Group);
Vue.use(Antd);
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
