require 'test_helper'

class VehiculosControllerTest < ActionController::TestCase
  setup do
    @vehiculo = vehiculos(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:vehiculos)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create vehiculo" do
    assert_difference('Vehiculo.count') do
      post :create, vehiculo: { a_c: @vehiculo.a_c, anho: @vehiculo.anho, categoria: @vehiculo.categoria, chasis: @vehiculo.chasis, color: @vehiculo.color, costo: @vehiculo.costo, disponible: @vehiculo.disponible, es_4x4: @vehiculo.es_4x4, gps: @vehiculo.gps, kilometraje: @vehiculo.kilometraje, marca: @vehiculo.marca, modelo: @vehiculo.modelo, n_motor: @vehiculo.n_motor, n_puertas: @vehiculo.n_puertas, patente: @vehiculo.patente, tipo_combustible: @vehiculo.tipo_combustible }
    end

    assert_redirected_to vehiculo_path(assigns(:vehiculo))
  end

  test "should show vehiculo" do
    get :show, id: @vehiculo
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @vehiculo
    assert_response :success
  end

  test "should update vehiculo" do
    patch :update, id: @vehiculo, vehiculo: { a_c: @vehiculo.a_c, anho: @vehiculo.anho, categoria: @vehiculo.categoria, chasis: @vehiculo.chasis, color: @vehiculo.color, costo: @vehiculo.costo, disponible: @vehiculo.disponible, es_4x4: @vehiculo.es_4x4, gps: @vehiculo.gps, kilometraje: @vehiculo.kilometraje, marca: @vehiculo.marca, modelo: @vehiculo.modelo, n_motor: @vehiculo.n_motor, n_puertas: @vehiculo.n_puertas, patente: @vehiculo.patente, tipo_combustible: @vehiculo.tipo_combustible }
    assert_redirected_to vehiculo_path(assigns(:vehiculo))
  end

  test "should destroy vehiculo" do
    assert_difference('Vehiculo.count', -1) do
      delete :destroy, id: @vehiculo
    end

    assert_redirected_to vehiculos_path
  end
end
