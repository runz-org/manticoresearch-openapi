=begin
#Manticore Search API

#This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: adrian.nuta@manticoresearch.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OpenapiClient::PercolateRequestQuery
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'PercolateRequestQuery' do
  before do
    # run before each test
    @instance = OpenapiClient::PercolateRequestQuery.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of PercolateRequestQuery' do
    it 'should create an instance of PercolateRequestQuery' do
      expect(@instance).to be_instance_of(OpenapiClient::PercolateRequestQuery)
    end
  end
  describe 'test attribute "percolate"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
