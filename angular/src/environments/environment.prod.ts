import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BasicEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44346/',
    redirectUri: baseUrl,
    clientId: 'BasicEcommerce_App',
    responseType: 'code',
    scope: 'offline_access BasicEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44313',
      rootNamespace: 'BasicEcommerce',
    },
  },
} as Environment;
