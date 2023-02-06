import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'FirstApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44360/',
    redirectUri: baseUrl,
    clientId: 'FirstApp_App',
    responseType: 'code',
    scope: 'offline_access FirstApp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'MBAbp.FirstApp',
    },
  },
} as Environment;
